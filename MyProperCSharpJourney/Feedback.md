# Feedback

## 2025/01/18
Well done Ian, I love Milo! It looks like you had a lot of fun creating that project, and you have a made an excellent start to this course. It's a shame that you had issues with your previous repository, it would have been nice to have kept a record of last week's work, but that's just a small thing. A couple comments based on the exercises this week, (mainly related to Milo, being your most significant project this week):

- Well done for using the Thread.Sleep() method, you've shown your initiative to use something that was not taught in the module
- I remember your preference for using `string1 + " " + string2`, but you will probably find the interpolation (introduced in this module) easier to use in the future: `$"{string1} {string2}"`
- Tiny thing - just check your response to Milo's question re. favourite food. This might have been more obvious if you had used string interpolation (as mentioned above)

In summary though, a great start, Ian. Keep up the good work!

## 20205/01/25
Greate work Ian. Synapse was fun to use! 
Great use of method. I know we haven't reached that far in the course yet. But they are a great way to keep your code clean.
Also, well done for using the `Console.ReadLine()` to allow the user to read your messages before continuing.

Here are a couple of comments:

- A switch statement would be a great choice for you game selection. See if you can incorporate that. ie: 
	- 
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