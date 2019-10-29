﻿namespace Nager.AmazonProductAdvertising.Model
{
    public class SearchRequest
    {
        public string Keywords { get; set; }
        public int? ItemPage { get; set; }
        public SortBy? SortBy { get; set; }
        public string BrowseNodeId { get; set; }
        public string[] Resources { get; set; }
        public Merchant? Merchant { get; set; }
    }
}