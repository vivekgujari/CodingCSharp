using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public class Trie
    {
        public class TrieNode
        {
            public char Value;
            public Dictionary<char, TrieNode> Children;
            public bool EndOfWord;
            public TrieNode(char Value)
            {
                this.Value = Value;
                this.Children = new Dictionary<char, TrieNode>();
                this.EndOfWord = false;
            }
        }

        public TrieNode root;
        public int WordCount;

        public Trie()
        {
            root = new TrieNode(' ');
            WordCount = 0;
        }

        public void AddWord(string word)
        {
            if (word == null || word.Length == 0)
                return;

            TrieNode temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.Children.ContainsKey(word[i]))
                {
                    temp.Children.Add(word[i], new TrieNode(word[i]));
                }
                temp = temp.Children[word[i]];
            }
            temp.EndOfWord = true;
            WordCount++;
        }
    }
}
