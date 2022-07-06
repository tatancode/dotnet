using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blogger.Models;

namespace Blogger.Controllers
{
    public class ChangeLogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChangeLogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChangeLogs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChangeLogs.Include(c => c.Blog);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ChangeLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeLog = await _context.ChangeLogs
                .Include(c => c.Blog)
                .FirstOrDefaultAsync(m => m.ChangeLogId == id);
            if (changeLog == null)
            {
                return NotFound();
            }

            return View(changeLog);
        }

        // GET: ChangeLogs/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "BlogId");
            return View();
        }

        // POST: ChangeLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChangeLogId,BlogId,UserId,ChangeLogType,Description,Comment,TimeStamp")] ChangeLog changeLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(changeLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "BlogId", changeLog.BlogId);
            return View(changeLog);
        }

        // GET: ChangeLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeLog = await _context.ChangeLogs.FindAsync(id);
            if (changeLog == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "BlogId", changeLog.BlogId);
            return View(changeLog);
        }

        // POST: ChangeLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChangeLogId,BlogId,UserId,ChangeLogType,Description,Comment,TimeStamp")] ChangeLog changeLog)
        {
            if (id != changeLog.ChangeLogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(changeLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChangeLogExists(changeLog.ChangeLogId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "BlogId", changeLog.BlogId);
            return View(changeLog);
        }

        // GET: ChangeLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeLog = await _context.ChangeLogs
                .Include(c => c.Blog)
                .FirstOrDefaultAsync(m => m.ChangeLogId == id);
            if (changeLog == null)
            {
                return NotFound();
            }

            return View(changeLog);
        }

        // POST: ChangeLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var changeLog = await _context.ChangeLogs.FindAsync(id);
            _context.ChangeLogs.Remove(changeLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChangeLogExists(int id)
        {
            return _context.ChangeLogs.Any(e => e.ChangeLogId == id);
        }
    }
}
