# Duplicate-Images

## 1. Background:

This is a .Net Core console application, which print all the duplicate images while merge image folders.

## 2. Frameworks and Libraries:

* .Net Core 2.2 Console Application
* Microsoft.VisualStudio.TestTools.UnitTesting
* System.Drawing


## 3. How to run:

Visual Studio(preferred):  

I recommend to use visual studio because you can directly open the solution file and then click **F5** to run the project or Click the run button.

VS Code: 


Make sure restore all the libraries and then type

```
dotnet run
```



## 4. How to use:

https://i.ibb.co/1sy8Njy/Duplicate-Images.png



![Console](https://i.ibb.co/1sy8Njy/Duplicate-Images.png)

After run the console application you can see the duplicate images information.

## 5. Unit Tests

Follow TDD. Ensure high unit tests coverage percentage. Currently cover all the functions in services and helper.

## 6. Recommended improvements:

Given time limitation. Here are some improvement suggestion:

- async/await
- more unit tests
- Create images models
- If there are many images we can compress images before compare them
- Store images metadata to database and put images to AWS S3