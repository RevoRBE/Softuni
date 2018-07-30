using System;
using System.IO;
using FestivalManager.Core.IO.Contracts;

namespace FestivalManager.Core.IO
{
	public class StringReader : IReader
	{
		//private readonly System.IO.StringReader reader;

  //      public StringReader(string contents)
		//{
		//	this.reader = new System.IO.StringReader(contents);
		//}

  //      public StringReader() :this()
  //      {
  //      }

        public string ReadLine() => Console.ReadLine();
	}
}