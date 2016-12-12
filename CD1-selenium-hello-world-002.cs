//See the blog post at: http://theseleniumguys.com/2016/11/07/code-drill-1-selenium-c-hello-world/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpendQA.Selenium.IE;

IWebdriver.driver = new InternetExplorerDriver();
driver.Navigate().GoToURL("http://www.google.com");

IWebElement element = driver.FindElement(By.name("q"));
element.SendKeys("Hello, World!");

driver.FindElement(By.Name("btnG")).Click();

driver.Quit();
