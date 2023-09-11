using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Shared.Data
{
	public class AVLtree
	{
		public int Id {get; set;}
		public int Size {get; set;} = 0;
		public Entry Root {get; set;} = null;
		public Entry GetRoot() => Root;
		public int GetSize() => Size;
		public AVLtree(int id, int size, Entry root)
		=> (Id, Size, Root) = (id, size, root);
        public AVLtree(){}
		public Entry search(string Word)
		{
			if (Size == 0)
				return null;
			var node = Find(Word, Root);
			return node.Word == Word? node: null;
		}
		public List<Entry> ShowWordsInRange(char first, char last) 
		{
			var nodes = new List<Entry>();
			if (Size != 0)
				ShowRange(first, last, nodes);
			return nodes;
		}
		public static Entry Find(string Word, Entry e)
        {
			if(string.Compare(e.Word, Word, StringComparison.Ordinal) < 0)
			{
				if(e.RightChild != null)
					return Find(Word, e.RightChild);
				return e;
			}
			if(string.Compare(e.Word, Word, StringComparison.Ordinal) > 0)
			{
				if(e.LeftChild != null)
					return Find(Word, e.LeftChild);
				return e;
			}
			return e;
		}
		public Entry Insert(Entry e)
		{
			Entry node = NormalInsert(e);
			Rebalance(node);
			return node;
		}
		public void Delete(string Word)
		{
			Entry e = search(Word);
			if(e != null)
			{
				Entry node = NormalDelete(e);
				if(node != null)
					Rebalance(node.LeftChild);
			}
		}
		private Entry NormalInsert(Entry e)
        {
			if (Size++ == 0)
				return Root = e;
            var par = Find(e.Word, Root);
			e.Parent = par;
			if(e > par)
				par.RightChild = e;
			else
				par.LeftChild = e;
			// Size++;
			return e;
        }
        private Entry NormalDelete(Entry e)
        {
			Size--;
			if (Size == 0)
				return Root = null;
			Console.WriteLine(e.Height);
			if(e.LeftChild == null && e.RightChild == null)
			{
				if (e.Parent.LeftChild == e)
					e.Parent.LeftChild = null;
				else
					e.Parent.RightChild = null;
				return null;
			}
            if (e.RightChild == null)
			{
				e.LeftChild.Parent = e.Parent;
				if (e != Root)
				{
					if (e.Parent.LeftChild == e)
						e.Parent.LeftChild = e.LeftChild;
					else
						e.Parent.RightChild = e.LeftChild;
				}
				return e.LeftChild;
			}
			Entry x = Next(e);
			if(x != null)
			{
				if(x.RightChild != null)
					x.RightChild.Parent = x.Parent;
				if(x != Root)
				{
					x.Parent.LeftChild = x.RightChild;
				}
				x.Parent = e.Parent;
				if(e != Root)
				{
					if (e.Parent.LeftChild == e)
						e.Parent.LeftChild = x;
					else
						e.Parent.RightChild = x;
				}
				x.RightChild = e.RightChild;
				x.LeftChild = e.LeftChild;
			}
			return x;
        }

        private Entry Next(Entry e)
        {
			if(e == null)
				return null;
            if (e.RightChild != null)
				return LeftDescendant(e.RightChild);
			return RightAncestor(e);
        }

        private Entry RightAncestor(Entry e)
        {
			if(e == Root)
				return null;
            if (e < e.Parent)
				return e.Parent;
			return RightAncestor(e.Parent);
        }

        private Entry LeftDescendant(Entry node)
        {
            if (node.LeftChild == null)
				return node;
			return LeftDescendant(node.LeftChild);
        }

        private void Rebalance(Entry node)
        {
			if(node != null)
			{
				var p = node.Parent;
				if(node.LeftChild != null || node.RightChild != null)
				{
					if ((node.LeftChild == null? 0: node.LeftChild.Height) > (node.RightChild == null? 0: node.RightChild.Height)+1)
						RebalanceRight(node);
						
					if ((node.RightChild == null? 0: node.RightChild.Height) > (node.LeftChild == null? 0: node.LeftChild.Height)+1)
						RebalanceLeft(node);

				}
				AdjustHeight(node);
				Rebalance(p);
			}
        }

        private void AdjustHeight(Entry node)
        => node.Height = node == null? 0: Size == 1? 1: 1+ Math.Max
		(node.LeftChild==null?0:node.LeftChild.Height, node.RightChild==null?0:node.RightChild.Height);

        private void RebalanceLeft(Entry node)
        {
            Entry right = node.RightChild;
			var e = right.LeftChild;
			if ((e == null?0: e.Height) > (right.RightChild == null?0: right.RightChild.Height))
				RotateRight(right);
			// AdjustHeight on affected nodes
			RotateLeft(node);
			AdjustHeight(right);
			if(right.Parent == null)
				Root = right;
			else
				AdjustHeight(right.Parent);
			AdjustHeight(node);
			if(e != null)
			{
				AdjustHeight(e);
				if(e.Parent == null)
					Root = e;
				else
					AdjustHeight(e.Parent);
			}

        }

        private void RebalanceRight(Entry node)
        {
            Entry left = node.LeftChild;
			var e = left.RightChild;
			if ((e == null?0: e.Height) > (left.LeftChild == null?0: left.LeftChild.Height))
				RotateLeft(left);
			RotateRight(node);
			// AdjustHeight on affected nodes
			AdjustHeight(left);
			if(left.Parent == null)
				Root = left;
			else	
				AdjustHeight(left.Parent);
			if(e != null)
			{
				AdjustHeight(e);
				if(e.Parent == null)
					Root = e;
				else	
					AdjustHeight(e.Parent);
				AdjustHeight(node);
			}
        }

        private void RotateRight(Entry node)
        {
			var left = node.LeftChild;
			left.Parent = node.Parent;
			if (node.Parent != null)
			{
				if (node.Parent.LeftChild == node)
					node.Parent.LeftChild = left;
				else
					node.Parent.RightChild = left;
			}
			node.Parent = left;
			node.LeftChild = left.RightChild;
			left.RightChild = node;
        }

        private void RotateLeft(Entry node)
        {
            var right = node.RightChild;
			right.Parent = node.Parent;
			if (node.Parent != null)
			{
				if (node.Parent.LeftChild == node)
					node.Parent.LeftChild = right;
				else
					node.Parent.RightChild = right;
			}
			node.Parent = right;
			node.RightChild = right.LeftChild;
			right.LeftChild = node;
        }
		public void ShowRange(char x, char y, List<Entry> nodes)
		{
			var node = Find($"{x}", Root);
			while (node != null && node.Word[0] <= y)
			{
				if (node.Word[0] >= x)
					nodes.Add(node);
				node = Next(node);
			}
		}
    }
}
