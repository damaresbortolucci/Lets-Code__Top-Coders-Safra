﻿namespace MakeupStoreApi.Models
{
    public class Product
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string image_link { get; set; }
        public string description { get; set; }
        public object rating { get; set; }
        public string category { get; set; }
        public string product_type { get; set; }
        public List<string> tag_list { get; set; }
    }
}
