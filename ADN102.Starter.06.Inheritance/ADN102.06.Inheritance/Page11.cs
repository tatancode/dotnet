using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page11
{
   
    abstract class Stream
        {
            public abstract string Read(int numberOfCharactersToRead);
            public abstract void Write(string dataToWrite);
            public abstract bool Seek(int characterOffset);
            public abstract int CurrentPosition { get; }
        }

    abstract class BufferedStream : Stream
    {
        // introduce new abstract methods
        public abstract string RawRead(int numberOfCharactersToRead);
        public abstract void RawWrite(string dataToWrite);
        public abstract bool RawSeek(int characterOffset);
        public abstract int RawPosition { get; }

        // implement new functionality needed ONLY by a buffered stream
        public void Flush()
        {
            Console.WriteLine($"Flushing Buffer '{_buffer}' to RawStorage");
            RawWrite(_buffer.ToString());
            _buffer.Clear();
        }

        // the internal buffer to hold data physically read, but not logically read yet
        System.Text.StringBuilder _buffer;

        // Create constructors for a buffered stream : default size of buffer is 5 characters
        public BufferedStream()
        {
            _buffer = new StringBuilder(5);
        }
        public BufferedStream(int defaultBufferSize)
        {
            _buffer = new StringBuilder(defaultBufferSize);
        }


        // implement the behavior we can in the base class

        // READ
        // check the arguments to make sure they make sense
        // see if we can supply the requested data from our buffer
        //    if so - then get the requested data from the buffer and turn it to a string
        //            then remove the requested data from the buffer (since we just read it)
        //    if not  then compute how many extra characters we need to read
        //            call ReadRaw to read the raw data from storage, then put it in the buffer
        //       now get the data from the buffer and return it.

        public override string Read(int numberOfCharactersToRead)
        {
            if (numberOfCharactersToRead <= 0)
            {
                throw new Exception($"The number of characters to read must be greater than 0, you asked for {numberOfCharactersToRead}");
            }
            string rv;
            if (numberOfCharactersToRead <= _buffer.Length)
            {
                rv = _buffer.ToString(0, numberOfCharactersToRead);
                _buffer.Remove(0, numberOfCharactersToRead);
                return rv;
            }
            Console.WriteLine($"Buffer['{_buffer}'] is Low: needed {numberOfCharactersToRead} but only had {_buffer.Length}  Reading more from RawStorage");
            _buffer.Append(RawRead(_buffer.Capacity));
            if (numberOfCharactersToRead < _buffer.Length)
            {
                rv = _buffer.ToString(0, numberOfCharactersToRead);
                _buffer.Remove(0, numberOfCharactersToRead);
                return rv;
            }
            else
            {
                rv = _buffer.ToString();
                _buffer.Clear();
                return rv;
            }
        }


        // WRITE
        // compute how much free space is available in the buffer for writing.  Capacity is the total amount of space, and Length is the amount currently being used.
        //  If there is not enough free space to hold the new data, 
        //       then write the buffer to Raw storage using RawWrite
        //       clear the buffer, remove the data written and try again.
        //  when there is enough space to hold the data, add it to the buffer
        public override void Write(string dataToWrite)
        {
            int amountFree = _buffer.Capacity - _buffer.Length;
            while (dataToWrite.Length >= amountFree)
            {
                Console.Write($"Buffer is full: needed {dataToWrite.Length} but only had {amountFree}  Writing buffer to RawStorage:");
                _buffer.Append(dataToWrite.Substring(0, amountFree));
                dataToWrite = dataToWrite.Remove(0, amountFree);
                Console.WriteLine($"'{_buffer}'");
                RawWrite(_buffer.ToString());
                _buffer.Clear();
                amountFree = _buffer.Capacity;
            }
            if (dataToWrite.Length > 0)
            {
                _buffer.Append(dataToWrite);
            }


        }

        // When seeking, flush any data currently written in the buffer and the seek to the new position

        public override bool Seek(int characterOffset)
        {
            Flush();
            return RawSeek(characterOffset);
        }

        // compute the new position from the raw position and the data in the buffer
        public override int CurrentPosition
        {
            get
            {
                return RawPosition + _buffer.Length;
            }
        }
    }

    class FileStream : BufferedStream
    {
        // fields containing data needed to implement file logic: we need to know where we are in the file and what the file name is
        int _position;
        string _fileName;


        // constructor: no default constructor is provided because you MUST at least supply a filename
        // the bufferSize is option, and if you do not supply it, the value of 10 will be used
        public FileStream(string path, int bufferSize = 10)
            : base(bufferSize)
        {
            _fileName = path;
        }

        // the required implementation of RawPosition needed for a BUFFERED stream
        public override int RawPosition
        {
            get { return _position; }
        }

        // the required implementation of RawRead needed for a BUFFERED stream
        public override string RawRead(int numberOfCharactersToRead)
        {
            // simulate a file by getting the data from the console.
            Console.Write($"Supply {numberOfCharactersToRead} letters from file '{_fileName}' at position {_position}:");
            string rv = Console.ReadLine();
            if (rv.Length > numberOfCharactersToRead)
            {
                Console.WriteLine($"Truncating input to '{rv.Substring(0, numberOfCharactersToRead)}'");
                _position += numberOfCharactersToRead;
                Console.WriteLine($"{numberOfCharactersToRead} from file {_fileName} at position {_position} data:'{rv.Substring(0, numberOfCharactersToRead)}'");
                return rv.Substring(0, numberOfCharactersToRead);
            }
            _position += rv.Length;
            return rv;
        }


        // the required implementation of RawSeek needed for a BUFFERED stream
        public override bool RawSeek(int characterOffset)
        {
            _position = characterOffset;
            return true;
        }

        // the required implementation of RawWrite needed for a BUFFERED stream

        public override void RawWrite(string dataToWrite)
        {

            _position += dataToWrite.Length;
        }



    }


    class NetworkStream : BufferedStream
    {

        public NetworkStream(string protocol, int port, string path)
        {
            NetworkPath = $"{protocol}:{port}/{path}";
        }
        public override int RawPosition => 0;

        public string NetworkPath { get; set; }



        public override string RawRead(int numberOfCharactersToRead)
        {
            Console.Write($"Read {numberOfCharactersToRead} From Network port: {NetworkPath}:");
            string rv = Console.ReadLine();
            if (rv.Length > numberOfCharactersToRead)
            {
                Console.WriteLine($"Data Truncated to: '{rv.Substring(0, numberOfCharactersToRead)}'");

                return rv.Substring(0, numberOfCharactersToRead);
            }
            Console.WriteLine($"Read '{rv}' from {NetworkPath}");
            return rv;
        }

        public override bool RawSeek(int characterOffset)
        {
            return false;
        }

        public override void RawWrite(string dataToWrite)
        {
            Console.WriteLine($"Write to Network Port: {NetworkPath}: '{dataToWrite}'");
        }
    }

    class Program
    {
        public static void Main()
        {
            //BufferedStream fs = new NetworkStream("http", 80, "Test.txt");
            BufferedStream fs = new FileStream("Test.data");

            fs.Write("Hello");              // write 5 characters;   total of 5 sent
            fs.Write(" There");             // write 6 characters;   total of 11
            fs.Write(" How");               // write 4 more;         total of 15
            fs.Write(" Are You Today.  I am Fine.  Are you doing well?");
            // write 48 more;        total of 63
            // fs.Flush();                  // three characters are in the buffer (ll?)

            Console.WriteLine($"Main Reads 6: '{fs.Read(6)}'");   // total of 6 read
            Console.WriteLine($"Main Reads 5: '{fs.Read(5)}'");   // total of 11 read
            Console.WriteLine($"Main Reads 4: '{fs.Read(4)}'");   // total of 15 read
            Console.WriteLine($"Main Reads 3: '{fs.Read(3)}'");   // total of 18 read
            Console.WriteLine($"Main Reads 3: '{fs.Read(3)}'");   // total of 21 read
            Console.WriteLine($"Main Reads 2: '{fs.Read(2)}'");   // total of 23 read
            Console.WriteLine($"Main Reads 1: '{fs.Read(1)}'");   // total of 24 read
            Console.WriteLine($"Main Reads 6: '{fs.Read(6)}'");   // total of 30 read

        }
    }
}

