using System;

namespace Sinemasyon
{
    internal class ComboBoxItem
    {
        public string Text { get; set; } // ComboBox'ta gösterilecek metin
        public object Tag { get; set; }  // Ek veri tutmak için kullanılan alan

        public override string ToString()
        {
            return Text; // ComboBox'ta görüntülenecek metni döndürür
        }
    }
}
