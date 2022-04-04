# General Description
This is a Console Application written in C# using the latest .Net 6
This is a program executable from the command line that when given text(s) files will return 100 of most common three word sequences in descending order of frequency.
There are 3 zip files:
1. NewRelic - Published executable
2. NewRelicTest - Published Test dll
3. NewRelicSolution - Raw Code

# Requirements
 Microsoft .Net 6 to run
 To open the project, preferebaly use Visual Studio 2022 Version 17.x or any other compatible IDE


# Application Setup
Copy the NewRelic zip file and extract the files into your desired folder
Once you unzip you should see NewRelic.exe file along with all its .Net dependencies and texts folder containing the sample text files

Copy the NewRelicTest zip file and extract the files into your desired folder
Once you unzip you should see NewRelicTest.dll file along with all its .Net dependencies and texts folder containing the sample text files

# How to run the Program
From the command line run NewRelic.exe by providing one or more command line arguments with valid text file names
There are two files in the "texts" folder moby-dick.txt and brothers-karamazov.txt

You can use either one or both.

For example:
C:\Temp\NewRelic>NewRelic texts\moby-dick.txt texts\brothers-karamazov.txt

or

C:\Temp\NewRelic>NewRelic texts\moby-dick.txt

you will see the following output *simliar* to

```
[the sperm whale, 86]
[of the whale, 78]
[the white whale, 71]
[one of the, 64]
[of the sea, 57]
[out of the, 57]
[part of the, 53]
[a sort of, 51]
```


# How to run the Tests
Copy the NewRelicTest zip file and extract the files into your desired folder
Once you unzip you should see NewRelicTest.dll file along with all its .Net dependencies and texts folder containing the sample text files

From the Command line where this NewRelicTest zip file is located run the below command:
C:\Temp\NewRelicTest>dotnet test NewRelicTest.dll

you will see the following output *simliar* to
```
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 531 ms - NewRelicTest.dll (net6.0)
```

# What you would do next, given more time (if anything)?
Error Logging

# Are there bugs that you are aware of?
No