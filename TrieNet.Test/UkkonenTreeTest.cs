﻿using NUnit.Framework;

namespace Gma.DataStructures.StringSearch.Test
{
    [TestFixture]
    public class UkkonenTreeTest : SuffixTrieTest
    {
        protected override ITrie<int> CreateTrie()
        {
            return new UkkonenTree<int>(0);
        }
    }
}