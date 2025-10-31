namespace MultiShop.RapidApiWebUI.Models
{
    public class ECommerceViewModel
    {


        public class Rootobject
        {
            public string status { get; set; }
            public string request_id { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Product[] products { get; set; }
            public object[] sponsored_products { get; set; }
            public Filter[] filters { get; set; }
        }

        public class Product
        {
            public string product_id { get; set; }
            public string product_title { get; set; }
            public string product_description { get; set; }
            public string[] product_photos { get; set; }
            public Product_Videos[] product_videos { get; set; }
            public Product_Attributes product_attributes { get; set; }
            public float product_rating { get; set; }
            public string product_page_url { get; set; }
            public int product_num_reviews { get; set; }
            public int? product_num_offers { get; set; }
            public string[] typical_price_range { get; set; }
            public Current_Product_Variant_Properties current_product_variant_properties { get; set; }
            public Product_Variants product_variants { get; set; }
            public Reviews_Insights reviews_insights { get; set; }
            public Offer offer { get; set; }
        }

        public class Product_Attributes
        {
            public string DPI { get; set; }
            public string Sensor { get; set; }
            public string NumberofButtons { get; set; }
            public string Programmable { get; set; }
            public string OS { get; set; }
            public string Devices { get; set; }
            public string MouseType { get; set; }
            public string ConnType { get; set; }
            public string WirelessTech { get; set; }
            public string ReceiverType { get; set; }
            public string USBType { get; set; }
            public string HandOrientation { get; set; }
            public string GripStyle { get; set; }
            public string Adjustability { get; set; }
            public string ErgonomicDesign { get; set; }
            public string PalmSupport { get; set; }
            public string Vertical { get; set; }
            public string WristRest { get; set; }
            public string Dimensions { get; set; }
            public string Shape { get; set; }
            public string Weight { get; set; }
            public string Material { get; set; }
            public string ScrollWheelType { get; set; }
            public string Style { get; set; }
            public string Lighting { get; set; }
            public string Mini { get; set; }
            public string TopUseCases { get; set; }
            public string TypicalUsers { get; set; }
            public string Multitouch { get; set; }
            public string Highlights { get; set; }
            public string Software { get; set; }
            public string CableLength { get; set; }
            public string PollingRate { get; set; }
            public string TrackingSpeed { get; set; }
            public string ResponseTime { get; set; }
            public string Finish { get; set; }
            public string Brand { get; set; }
            public string Colour { get; set; }
            public string Connectivity { get; set; }
            public string Type { get; set; }
        }

        public class Current_Product_Variant_Properties
        {
            public string Colour { get; set; }
        }

        public class Product_Variants
        {
            public Colour[] Colour { get; set; }
        }

        public class Colour
        {
            public string name { get; set; }
            public string thumbnail { get; set; }
            public string product_id { get; set; }
        }

        public class Reviews_Insights
        {
        }

        public class Offer
        {
            public string offer_id { get; set; }
            public string offer_title { get; set; }
            public string offer_page_url { get; set; }
            public string price { get; set; }
            public object original_price { get; set; }
            public bool on_sale { get; set; }
            public string shipping { get; set; }
            public string returns { get; set; }
            public string product_condition { get; set; }
            public string store_name { get; set; }
            public string store_rating { get; set; }
            public int store_review_count { get; set; }
            public object store_reviews_page_url { get; set; }
            public string store_favicon { get; set; }
            public object payment_methods { get; set; }
        }

        public class Product_Videos
        {
            public string title { get; set; }
            public string url { get; set; }
            public string source { get; set; }
            public string publisher { get; set; }
            public string thumbnail { get; set; }
            public string preview_url { get; set; }
            public int duration_ms { get; set; }
        }

        public class Filter
        {
            public string title { get; set; }
            public bool multivalue { get; set; }
            public Value[] values { get; set; }
        }

        public class Value
        {
            public string title { get; set; }
            public string q { get; set; }
            public string shoprs { get; set; }
        }


    }
}
