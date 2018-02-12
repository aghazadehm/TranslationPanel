using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PhraseTypes
    {
        public IEnumerable<PhraseType> Items { get { return _types; } }
        private PhraseType[] _types = new PhraseType[]
        {
            new PhraseType(1, "broker", "کارگزاری"),
            new PhraseType(2, "customer", "مشتری"),
            new PhraseType(3, "contract type", "نوع قرارداد"),
            new PhraseType(4, "commodity main group", "گروه اصلی کالا"),
            new PhraseType(5, "commodity midlle group", "گروه میانی کالا"),
            new PhraseType(6, "commodity sub group", "زیر گروه کالا"),
            new PhraseType(7, "commodity", "کالا"),
            new PhraseType(8, "delivery place", "محل تحویل"),
            new PhraseType(9, "ring", "تالار"),
            new PhraseType(10, "producer", "تولید کننده"),
            new PhraseType(11, "currency", "واحد ارز"),
            new PhraseType(12, "measurement unit", "واحد اندازه گیری"),
            //new PhraseType(13, "", ""),
        };

        public PhraseType this[int index]
        {
            get
            {
                return _types[index];
            }
            set
            {
                _types[index] = value;
            }
        }
    }
}
