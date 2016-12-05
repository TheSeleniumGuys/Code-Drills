//See the blog post at: 

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpendQA.Selenium.IE;

IWebdriver.driver = new InternetExplorerDriver();

driver.Navigate().GoToURL("http://www.google.com");
driver.FindElement(By.XPath("//input[@value='Google Search']")).SendKeys("Hello, World!");
driver.FindElement(By.XPath("//input[@value='Google Search']")).Click();

driver.Quit();
