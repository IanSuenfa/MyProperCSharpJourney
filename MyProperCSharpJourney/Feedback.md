# Feedback

## 2025/01/18
Well done Ian, I love Milo! It looks like you had a lot of fun creating that project, and you have a made an excellent start to this course. It's a shame that you had issues with your previous repository, it would have been nice to have kept a record of last week's work, but that's just a small thing. A couple comments based on the exercises this week, (mainly related to Milo, being your most significant project this week):

- Well done for using the Thread.Sleep() method, you've shown your initiative to use something that was not taught in the module
- I remember your preference for using `string1 + " " + string2`, but you will probably find the interpolation (introduced in this module) easier to use in the future: `$"{string1} {string2}"`
- Tiny thing - just check your response to Milo's question re. favourite food. This might have been more obvious if you had used string interpolation (as mentioned above)

In summary though, a great start, Ian. Keep up the good work!

## 2025/01/25
Greate work Ian. Synapse was fun to use! 
Great use of method. I know we haven't reached that far in the course yet. But they are a great way to keep your code clean.
Also, well done for using the `Console.ReadLine()` to allow the user to read your messages before continuing.

Here are a couple of comments:

- A switch statement would be a great choice for you game selection. See if you can incorporate that. ie: 
	```
	switch (game) 
	{ 
		case "1": ... 
		case "2": ... 
	}
	```
- A bit more advanced, but if at all possible, try not to nest you `if` statements too much. No nesting is ideal, but a depth of 1 is ok. One way to achieve this is by checking for a 'small' case and then, in your case, continuing with the next iteration of the while loop. Feel free to ask if you need more clarification on this.
- The `Console.Write("... \r\n")` is interesting. I imagine it was possibly AI generated? I only say 'iteresting' as the `\r\n` could have been eliminated with use of `Console.WriteLine`. There's no reason why you should know this just yet, but you can use multi-line strings using 3 quotes: ie:
  ```
	var myMultiLineString = """
		my first line
		my second line
	""";
	
	Console.WriteLine(myMultiLineString);
  ```
- Finally, have a go at using interpolation: ie `$"My name is {name}"` instead of `My name + " is " name"`. Once you've tried it, you can see which one you like better.

## 2025/02/01
A slow one this week, but I know this was due to illness. If you're feeling better next week, it would be good to do as much as you can to finish the introduction course and complete all introduction exercises in the Exercise folder, (not including the Exercism questions necessarily). I'm not sure how possible this will be, but if you could aim to get as much of that done as possible it would be good to get us back on track.

## 2025/02/22
Well done with your ATM exercise! You have shown a good of understanding of the use of the Random class, the while loop and decrementing values.

The `break` command wasn't used exactly as I had hoped, I had hoped that you would break out of the loop on the input of a correct PIN before the third attempt. It is not really intended to finish a program. In order to know how to proceed from there, the use of a bool - `isPinCorrect` would have been useful. Here is an example:

```
Random random = new Random();
int pin = random.Next(1000, 10000);
int attempts = 3;
bool isPinCorrect = false;

while (attempts > 0)
{
	Console.Write("Enter your pin: ");
	int input = Convert.ToInt32(Console.ReadLine());

	if (input == pin)
	{
		isPinCorrect = true;
		break;
	}

	attempts--;
	Console.WriteLine($"Incorrect pin. You have {attempts} attempts left.");
}

if (isPinCorrect)
{
	Console.WriteLine("Correct pin entered.");
	// Now you can ask questions about withdrawing and depositing.
}
else
{
	Console.WriteLine("You have run out of attempts.");
}
```

Notice that you don't need the `else` - if we hit the `break`, then we won't reach the next line.

## 2025/03/01
Well done Ian. I noticed that you have completed 2 exercises. I also noted that you had completed the Guess Game some time ago, so will also comment on that.

### Doing Math (Calculator)
I hadn't expected that you would create a calculator for the user, this was just one of the early exercises to familiarise yourself with the ability to do maths in C#. However, well done - you even found a class that I didn't know existed, (ie: the DataTable class), and also discovered the `try-catch` syntax.

### Ride
Your method certainly works. However, I was hoping that you could practice the `continue` statement, something like this -

```
	for(int i = 1; i < 14; i++)
	{
		if (i < 7) 
		{
			contiue;
		}

		Console.WriteLine($"You're {i}? Come right inside");
	}
```

### Guess Game
You mentioned that this is unfinished? Is that because it lacks error handling if the user enters a non numeric input? If this is the case, it seems that you have discovered the `try-catch` syntax in your calculator, which you can also use here.
Alternatively, instead of using `Convert.ToInt32`, you could use `int.TryParse` which will return a boolean value if the conversion was successful and provide you with the integer value as an `out` parameter. This way you can check if the user has entered a number before proceeding, like this -

```
	const isParsed = int.TryParse(Console.ReadLine(), out int guess);

	if (!isParsed)
	{
		Console.WriteLine("Please enter a number");
		continue;
	}

	// The rest of your code
```

I'd really like to see if we can finish these first exercises next week, I think we just have the Logical Operators, switch as ternary operator. The first one might take a bit longer, but I think the second 2 should be quite short.
I think it would be nice to start your final project at the beginning of May, which means that we need to have finished the second part of the course by then. I also need to fill in some gaps at the end, which will also need time.

## 2025/03/08
You didn't do the exercises I had expected, but the Exercism exercises you did covered the switch statment (in SpaceAge)  and logical operators, (in Leap). Don't worry about the terneray operator now, it's a fairly small thing and can be used in the future.

### Leap
This was a good opportunity to show your use of logical operators. However, a nicer and more readable way to show this could have been with a method like this
```	
private bool IsLeapYear(int year)
{
	if (year % 400 == 0)
		return true;

	if (year % 100 == 0)
		return false;

	if (year % 4 == 0)
		return true;

	return false;
}
```

### SpaceAge
One of the mantras of good programming is DRY - Don't Repeat Yourself. This is so that if you need to change something, you only need to do it in one place instead of multiple.
Have a look at where repetition occurs and see if you can create a method to handle this.  
Knowledge of Dictionaries would have been nice for this one, but this will come later in the course.

Well done though. I think you can continue onto the C# intermediate course now.

## 2025/03/15
Well done on completing the Classes and Objects module. This is the essence of Object Oriented Programming. Here are a couple pointers.
* classes generaly have their own file. Creating the file will automatically create the class.
* classes are usually public (which you will need to check if you get an error that it cannot be accessed)
* class, property and method names are PascalCase (first letter of each word is capitalised)
* class fields are camelCase (first letter is lowercase, then each word is capitalised) and are precded by a `_`, eg: `_myField_`
* although you have seen a lot of examples with logic in the getters and setters, this implementation is acually very rare. It's good to know about, but in practice, we generally use -
```
public string MyProperty { get; set; }
```
as opposed to -
```
public string MyProperty
{
	get { return _myProperty; }
	set { _myProperty = value; }
}
```

Next, try the exercise in the Exercises folder on Tyranids.

## 2025/03/22
Don't worry about this slow week, Ian. Dealing with the unexpected is all part of software development. Well done for managing to sort out the problem, that is all part of learning too.

## 2025/03/29
Well done Ian, I see that in some ways you have done more than expected, incorporating inheritance, abstract classes and protected members into your project, which I believe will come later in the course. Well done.

I think you might have have slightly misunderstood the role of the class, which is completely understandable as it is a new paradigm. I also remember having trouble with this when I first started. You are now learning about instance classes which can be instantiated using the `new` keyword. These are different to the static classes that you are more accustomed to.

Think of an class like a librarian stamp, which is used by the librarian to make as many imprints of that stamp as they want. In this case, the stamp is the class and the imprints are the 'objects' of that class. The stamp does not use itself, but instead is used by something (or someone) else. Similarly, a class generally does not use or instantiate itself into an object, but instead is used by another area of code to instantiate an object. The calling code can then use the public members of that newly instantiated object.

```
public class Tyranid
{
	// here is my tyranid functionality
}

public static class CallingClass
{
	var myFirstTyranid = new Tyranid();		// first object (or imprint)
	var mySecondTyranid = new Tyranid();	// second object (or imprint)

	var status = myFirstTyranid.Status();	// using the public members
}
```

Maybe instantiating 2 or 3 objects from the same class in your calling code can help to solidify this idea.

You will also find later than instance classes can also be used by other instance classes, and not just by static classes.

eg. (Silly example, but you get the idea)
```
public class SpaceMarine
{
	private Tyranid _petTyranid;

	public SpaceMarine()
	{
		_petTyranid = new Tyranid();
	}
}
```

Also, while it is not necessarily incorrect to add multiple classes to the same file, it is generally a good practice to have one class per file. If you would like to organise these, you could do so using folders.
eg:

* TyranidExcercise (Folder)
  * Units (Folder)
	* Unit (abstract class)
	* Tyranid
	* SpaceMarine
  * WhGame

It looks as though you still have a few members methods to implement. Add these in so they can be used in the items 1 -12 in your static class.