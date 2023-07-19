Project's name:
    DecemberLabsProjects

Description:
    Test automation project that uses NUnit, C#, and Selenium WebDriver to perform UI tests on DecemberLabs web applications.

Requirements:
    Make sure you have the following tools installed before you begin:
        - Microsoft Visual Studio (version 2022).
        - Chrome browser (Last version).

To be able to run the project:
    - Clone this repository to your local machine.
    - Open the project in Visual Studio.

Project Structure
    - Tests folder: Contains the test classes where the scenarios and test cases are defined using NUnit and Selenium WebDriver.

    - PageObject folder: Contains the classes that represent the web pages of the application under test. These classes encapsulate the elements and actions of the user interface.
    
    - Bases folder: Contains the base classes which are used to establish a solid and reusable base for testing.

Base Classes:
    - BaseDriver: This class encapsulates the creation and management of the WebDriver, allowing for centralized configuration and easier management of browser instances. It provides methods to initialize and close the WebDriver before and after each test.

    - BasePageObject: This base class is intended to be inherited by all classes that represent application web pages. Contains common methods and properties for interacting with UI elements, and performing specific actions that are general to all Page Objects.

    - BaseTest: This class is meant to be inherited by all Test classes, it uses the BaseDriver class to create its Driver property so it can use the (Initdriver() and DestroyDriver()) methods within the [SetUp] and [Teardown] which will allow to indicate when executing each test to open and close the browser automatically.

PageObjects classes: They store the elements and methods to interact with the components of each page in the application.

Test classes: Store the test scripts related to the page being tested.

To run Test Cases: 
    On Visual Studio, in superior menu click on VIEWS option
    - To see the complete structure of the project select ----> "Solution Explorer" 
    - To run Testcases ----> "Test Explorer" :
    - The testcases classes will be shown like a dropdown, desglose it and made a right click over the testcase that you want to run, click RUN option.

Improvements:
    - On Blog page, on the articles elements some images are not been displayed.
    - On Career page Apply Now button open a modal that has fields not good validated and Get in Touch modal as well .
    - On bottom banner where office has their contacts information Montevideo and San Francisco are just simple strings instead of links like Austin.




# DecemberLabsProjects
