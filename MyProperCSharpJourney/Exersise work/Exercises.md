 # C# Introduction

## Getting Started

### Your first C# Program
1. define a variable called name
1. set the variable to your own name
1. print that variable to the console

### Doing Math
1. Use two variables, 10 and 3
1. Perform each of the arithmetic operations on them (+ - * / %)
1. You might be surprised by the quotient (if you’re not getting the expected answer, try declaring them as ‘double’s instead of ‘int’s.

## Operators and Strings

### User Input
1. ask the user for their name (ie: print the question to the console)
1. save the answer to a variable
1. greet the user by name (ie: Hello …)

## Decision Making

### The Else If statement
1. Ask the user who they are (think of 3 possibilities of who the user might be)
1. Ask a question to the user depending on who the user is
1. Print something if you don’t recognise the user (ie: who is not one of those 3 possibilities)

### Logical Operators
You are a bouncer, and will only admit people who -
* Look over 25, OR
* Have id AND are over 18.

There are 8 combinations, which you can check by asking the user for and providing for the following information. (This could also be achieved using nested loops, but don’t worry if this seems difficult at this stage)

### The switch statement
Do the same as in the “The If Else statement”, but using a switch statement

### The Ternary Operator
* Someone is asking where the toilets are. Use the user input to determine their gender.
* Use the conditional operator to set a Direction variable according to their answer, (left if male and right if female).
* print the direction they need to go.

## LOOPS

### The while loop
1. Research how to generate a random integer
1. Generate a random integer between 1 and 5
1. Ask the user to guess the number
1. for each wrong guess, prompt the user to try again
1. On a correct guess, congratulate the user.

### Break and Continue (Break)
1. Create an ATM:
1. Generate a random 4 digit code
1. Give the user 3 attempts to provide the correct code
1. Provide the relevant service if correct within 3 attempts
1. swallow the card if wrong on the third attempt.

### Break and Continue (Continue)
1. You are admitting children onto a ride with an age restriction
1. iterate through ages 1 – 10 (ie: for (var i = 1; i <= 10; i++) … )
1. if heights are less than 7, state that the child is too young, otherwise, continue through to the next child

<br><br>

# C# Intermediate

## Classes and Objects

### Fun with Tyranids

#### Setup

In your "ExerciseWork" folder, create, (each in their own file) -
1. a new class called “Tyranid” (this class will not be static)
1. a new static class called “ClassesAndObjects”, (as you have for previous exercises)

#### Tyranid class
In your Tyranid class add and implement the following members -

##### private fields
* _isAlive

##### Properties -
* Name { get; } // get only properties can still be set by the constructor
* Health { get; private set; } // private set means this can only be set by methods within the object
* Strength { get; }

##### Constructor -
* Set Name and Strength with constructor parameters
* Set Health to 100
* Set _isAlive to true

##### Methods -
* Attack()
  * think about what parameter you would need for this method
  * attack should be based on the tyranid’s strength
  * A dead tyranid cannot attack
* ReceiveDamage(damage)
  * this should decrease the tyranids health by the damage 
  * if health drops to zero or below, the tryanid dies
  * this might similar to the attack method. What does this method help with?
* Sleep (hours)
  * increases the health by the number of hours slept 
  * capped at 100
  * a dead tyranid cannot increase health through sleep.
* Status ()
  * this should log the health status of the tyranid to the console using its name

In your ClassesAndObjects class -

1. Instantiate two tyranids :)
2. Have one tyranid attack another tyranid :)
3. Use Status() to check that the other tyranid’s health decreases by the expected amount :)
4. Allow the injured tyranid to sleep for a number of hours :)
5. Use Status() to check that the tyranid’s health has recovered by the expected amount :)
6. Allow the injured tyranid to sleep for 100 hours :)
7. Use Status() to check that the tyranid’s health has not increased beyond 100 :)
8. Have the injured tyranid kill the other tyranid, (you could use a ‘for’ loop to attack) :)
9. Use Status() to check that the tyranid is dead. :)
10. Try to make the dead tyranid attack(), (and confirm that this is impossible) :)
11. Try to revive the dead tyranid using Sleep() :)
12. Use Status() to confirm that Health is still at zero. :)

(we can have the tyranids attack each other as part of the next array module)

<br><br>

# Extra

## Indexing strings
https://www.w3schools.com/cs/cs_strings_access.php
String methods (just have a look at the method names and definitions to know what there is).
https://www.programiz.com/csharp-programming/library/string

## Arrays (there’s more on arrays later)
https://www.w3schools.com/cs/cs_arrays.php

## Lists (similar to arrays)
https://www.programiz.com/csharp-programming/list

## LINQ methods
### Tutorial:
https://canro91.github.io/2021/01/18/LinqGuide/
### Exercises: 
1, 3, 4, and 11 should do it. You’re welcome to do more if you like.
https://www.w3resource.com/csharp-exercises/linq/index.php

## Dictionaries – this is mentioned later, but could be useful here.
### Tutorial:
https://www.programiz.com/csharp-programming/dictionary
### Exercise:
As an employee of the RSPB, your boss asked you do count the following birds over the period of an hour.
* robin
* starling
* blackbird
* sparrow

1. Create an array of these birds called ‘birdTypes’
1. Create an empty List called ‘birdsSeen’
1. Create a Dictionary called ‘birdCount’, whose key will be the bird type and value will be the count for that bird type, (What would be an appropriate starting value might be for each bird?)
1. Think of a way that you can populate the birdsSeen List with at least 20 birds, randomly using the birdTypes array.
1. Use a Linq method to change each of the birds in birdsSeen to start with a capital letter
1. Iterate over the birdsSeen List using a foreach loop to populate your birdCount Dictionary
1. Create a report to show how many of each bird there are, (you’ll need to iterate through the birds)
1. New data has come in from another report with 4 more blackbirds. Add this to your current count
1. Check that blackbirds have been updated as expected
1. Make a final report with your new data

<br><br>

# Exercism

These can be found and searched [here](https://exercism.org/tracks/csharp/exercises)

You may want to call your method multiple times with different parameters to check all cases.

1. Leap. 
2. Two fer . 
3. Space age .
4. Grains ,
5. Perfect Numbers
6. Collatz Conjecture
7. Difference of Squares
8. Armstrong numbers (possible, but hard at this point)
9. Darts (you probably already know that Pythagoras’ theorem will come in useful here)
10. Triangle
11. Raindrops
12. Beer song
13. Sieve