using System;

namespace MyProj.Shared.Data
{
	public class Entry
	{
		public int Id {get; set;}
		public Entry Parent { get; set; } = null;
        public Entry LeftChild { get; set; } = null;
        public Entry RightChild { get; set; } = null;
		public string Word { get; set; }
		public string Meaning { get; set; }
		public int Height {get; set;} = 0;
		public bool Selected {get; set;} = false;
        public Entry(string word, string meaning)
        => (Word, Meaning) = (word, meaning);

        public Entry()
        {}

        public static bool operator ==(Entry r, Entry l) 
		=> r is null? l is null: l is null? r is null: r.Equals(l);
		public static bool operator !=(Entry r, Entry l)
		=> r is null? !(l is null): l is null? !(r is null): !r.Equals(l);
		public static bool operator >(Entry r, Entry l)
		=> string.Compare(r.Word, l.Word, StringComparison.Ordinal) > 0;
        public static bool operator <(Entry r, Entry l)
		=> string.Compare(r.Word, l.Word, StringComparison.Ordinal) < 0;

		public override bool Equals(object obj)
		=> obj is string? Word.Equals(obj as string): 
		Word.Equals((obj as Entry).Word);

		public override int GetHashCode()
		=> Word == null? 0: Word.GetHashCode();
	}
}
