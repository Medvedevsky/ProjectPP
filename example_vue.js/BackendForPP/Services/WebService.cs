using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendForPP.Models;
using Microsoft.AspNetCore.Mvc;


namespace BackendForPP.Services
{
    public class WebService
    {
        public List<WebText> TextMailBox { get; set; }

        public WebService()
        {
            List<WebText> lines = new List<WebText>();
           
            if (TextMailBox == null)
                TextMailBox = lines;
        }

        public IEnumerable<WebText> GetData()
        {
            return TextMailBox;
        }

        public IEnumerable<WebText> PostText(WebText text)
        {
            TextMailBox.Add(text);
            return TextMailBox;
        }

            
    }
}
