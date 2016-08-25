using System.Collections;

namespace SoundSharp
{
    public class ProductInfo
    {
        public int intId;
        public string strMake;
        public string strModel;
        public double dblSize;
        public double dblPrice;
        public int intStock = 500;

        public ProductInfo(int intIdn, string strMaken, string strModeln, double dblSizen, double dblPricen)
        {
            this.intId = intIdn;
            this.strMake = strMaken;
            this.strModel = strModeln;
            this.dblSize = dblSizen;
            this.dblPrice = dblPricen;
        }

        public int Storage
        {
            get { return intStock; }
            set { intStock = value; }
        }
    }
    public class MP3
    {
        public static ArrayList Product = new ArrayList();

        public static void Mp3Info()
        {
            Product.Add(new ProductInfo(1, "GET technologies .inc", "HF 410", 4096, 129.95));
            Product.Add(new ProductInfo(3, "Innotivative", "XM 6000", 512, 79.95));
            Product.Add(new ProductInfo(2, "Far & Loud", "XM 6000", 8192, 224.95));
            Product.Add(new ProductInfo(4, "Resistance", "3001", 4096, 124.95));
            Product.Add(new ProductInfo(5, "CBA", "NXT volume", 2048, 159.05));
        }

        public static ArrayList GetPlayers()
        {
            return Product;
        }
    }
}
