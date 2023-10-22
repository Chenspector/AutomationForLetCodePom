# AutomationForLetCodePom
A C# + Selenium automation project I created for testing of functionality of software automation demo website
This C# library project(AutomationForLetCodePom) together with C# unit test project(SmokeTests) assemble this automation test solution in the following way:
The library project has selenium web driver and selenium support packages installed on it. The code on it uses the web driver to launch the browser,
access web pages and find HTML elements inside them. Once they are found, it manipulates them in order to test the functionality of the 
web page in different ways.

The Unit test project has a reference to the library project that links the two together. This link enables the classes in the library project to work together
with ones in the unit test. In this way it is possible for the unit test class to make assertions on the manipulations done on the web pages in the library project,
and determine the final result of the test, according to conditions I chose.

Every class in the library project represent a single web page on which we operate and include methods that are being run from inside of other methods in counterpart
class on the unit test project. The two classes have similar names (for example, the c# library class that tests the home page of the website will be called "Home Page"
while the unit test class will carry the name "Home Page Test").
The aforementioned methods are arranged in a way that performs some desegnated workflow on the webpage to test parts of its functionality.


This is how it looks like
This method is set to check a text box that's supposed to be disabled. The test method is set to make sure of that.
The unit test class method declares one boolean variable that will help determine if the test has passed
Then it calles two methods in the liberary project.
The first takes us to the "Input page" where the test takes place
The second uses reference of the boolean variable to determine if the text box is indeed disabled
Then, an assertion is made on the result of the returned boolean variable to determine whether the textbox 
is disabled(as expected) or not

[TestMethod]

		 public void Can_Check_If_Textbox_Is_Disabled()
         {
            bool answer = true;
            InputPage.GoTo();
            InputPage.CheckIfTextboxIsDisabled(ref answer);
            Assert.IsTrue(answer == false, "Could not enter");
         }

		This is the second method that's called on the library project - InputPage.CheckIfTextboxIsDisabled(ref answer);
		The method uses the "NoEdittxt", an IWebElement. All of the web page's elements were found on the page first and listed before any action was done in a Page Object Model fashion
		that enables us to perform actions on them without having to find them again and again

		public static void CheckIfTextboxIsDisabled(ref bool answer)
        {
            answer =  NoEditTxt.Enabled;
        }

As the example above suggests, once the methods on the library project have finished running, they go back to the unit test method which asserts the success of the action that was performed using the unit test 'Assert'
class. The assertion makes sure that the tested workflow succeeded in achieving the functional goal the unit test method was set to test.
the test results appear in visual studio "Test Explorer" window. 


How to run the tests:

The running of the tests is done in the following way:
Running single tests
Inside the unit test class, hover with the mouse over the selected test method name and select the right mouse button. then select "run test".
Running multiple tests
Can be done from visual studio "Test Explorer" window, using the "Run All" button, or the options under "Run" drop down, depending on the test you want to run.
