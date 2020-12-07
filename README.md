# InternetTestExample
Automation test examples using the-internet on Herokuapp.com

Setup:

To run this project you will need Visual Studio (preferably 2019) and may need to install the following related NUnit and Selenium WebDriver Nuget packages:

NUnit
NUnit3TestAdapter
Microsoft.Net.Test.Sdk
Selenium.Chrome.WebDriver
Selenium.Support
Selenium.WebDriver
DotNetSeleniumExtras.WaitHelpers

You will also need to have Chrome installed, preferably the latest stable version.

Potential improvements:
This project could be tidier and more efficient in several ways that I have had some trouble in implementing.
Specifically, I have spent a lot of time messsing with wait methods and eventually settled on defining a new 
explicit wait method per test. This is not how I would have ideally set this up, however my project management
in Visual Studio has been a bit rusty and I was unable to get a wait method to reference properly from my base test
file. This is also why I have opted to define a SetUp and Teardown per test group as I couldn't get my tests to honour
The settings I had put in my BaseTest.cs file (I am sure I am just missing something simple with class definitions).

Another such issue that my project could potentially have is in error handling, I have not set up any catches
for any exceptions in order to produce a custom error that would tell the user what went wrong, however it is
questionable whether I would want to over-engineer such simple tests to provide that quality without a reasonable
business requirement that makes that area a lot more sensitive or valuable. 

I could have also implemented working Gherkin code using Specflow, so that tests could be run using the gherkin test 
case itself, though I think such implementation is only practical on a larger codebase, it is hard for me to understand
why some of these cases may even require gherkin, though respect that a system may expect it. 

Though I use a lot of XPath to find my elements, this has been more to do with a lack of tags on the
website being tested itself. 

