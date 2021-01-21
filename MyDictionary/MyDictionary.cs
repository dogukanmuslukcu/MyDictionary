using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TW, TM>
    {
        TW[] words;
        TM[] means;
        public MyDictionary()
        {
            words = new TW[0];
            means = new TM[0];
        }

        public void AddWords(TW word,TM mean )
        {
            TW[] wordsTemp = words;
            TM[] meansTemp = means;

            words = new TW[words.Length + 1];
            means = new TM[means.Length + 1];
            for (int i = 0; i < wordsTemp.Length; i++)
            {
                words[i] = wordsTemp[i];
                means[i] = meansTemp[i];

            }

            words[words.Length - 1] = word; 

        }
        public TW[] Words
        {
            get { return words; }
        }
        public TM[] Means
        {
            get { return means; }
        }
    }
}
