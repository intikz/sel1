﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sel
{
    //strongly typed
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class Props
    {     
        //auto implemented property
        public static IWebDriver driver { get; set; }
    }
}
