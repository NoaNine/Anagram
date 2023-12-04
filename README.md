#Foxmindet_Task1

The project was created by Oleksandr Havlytskyi for educational purposes at the FoxmindEd course.

**The purpose of the project:** Learn to create string parsing function without regular expressions and covered with tests.

**Technology or principles have been mastered( or repeated):** GIT, MsTest, algorithms, naming conventions, regular expressions.

**Task description:**
Create a console application for reverse each word* in the input line

Example: "abcd efgh" => "dcba hgfe"; "Test" => "tseT"



All non-alphabetic symbols should stay in their original places.

Examples: 

"a1bcd efg!h" => "d1cba hgf!e"

"  a1bcd    efg!h" => "  d1cba    hgf!e" **



* Space is the divider for words in a line.

** Spaces (as one of non alphabetic symbols) should not be deleted from the result string.



Create a test project for checking the algorithm of the reverse.


What to do if you stuck (instructions for newbies):

1. Implement the method ReverseWord, which will reverse a single word. Do not use built-in functions/methods, like Array.Reverse or similar.
2. Implement one more method Reverse, which will reverse all words in the input string. This method should use the previous method.
3. Create a new class Anagram and move there all created methods, change main to follow new class implementation.
4. Check program works correctly as before moving.
5. Add a new project for Unit tests. Cover Anagram with tests. Tests should include alternatives for non-valid values (null etc).
6. Rewrite method ReverseWord to keep all non-alphabetic characters in their original position.
7. Add new unit tests to check words with non-alphabetic characters
