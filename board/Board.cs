namespace ToDo_Uygulaması
{
    public class Board
    {
        public Board(string baslik, string icerik, string atananKisi, string buyukluk)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.AtananKisi = atananKisi;
            this.Buyukluk = buyukluk;
        }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public string Buyukluk { get; set; }
    }
}