namespace AssignmentBasics02;


using System;

public class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Pages: {Pages}";
    }
}

public class Program
{
    public static void Main()
    {
        // Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
        Book book = new Book("C# Basics", 464);
        object bookAsObject = book;
        Console.WriteLine(bookAsObject);

        // Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());

        // Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
        // int pages = "464"; // Compile-time error: a string cannot be assigned directly to an int.
        int pages = 464;
        Console.WriteLine(pages);

        // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
        try
        {
            int divisor = 0; // Use a variable so the division is checked at runtime.
            int result = 10 / divisor;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }

        // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
        int pageCount = 300;
        double pageCountAsDouble = pageCount;
        Console.WriteLine(pageCountAsDouble);

        // Q06. Declare a double price = 49.99; then convert it into an int using a cast.
        double price = 49.99;
        int priceAsInt = (int)price;
        Console.WriteLine(priceAsInt); // 49; casting to int truncates the fractional part.

        // Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
        string pagesText = "464";
        int convertedPages = Convert.ToInt32(pagesText);
        Console.WriteLine(convertedPages);

        // Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
        string yearText = "2023";
        int year = int.Parse(yearText);
        Console.WriteLine(year);

        string badText = "abc";
        if (int.TryParse(badText, out int parsedNumber))
        {
            Console.WriteLine(parsedNumber);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

        // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
        int originalPages = 464;
        string pagesAsString = originalPages.ToString();
        Console.WriteLine(pagesAsString);
        Console.WriteLine(pagesAsString.GetType());

        // Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
        int copies = 100;
        object boxedCopies = copies;
        int unboxedCopies = (int)boxedCopies;
        Console.WriteLine(boxedCopies);
        Console.WriteLine(unboxedCopies);

        // Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
        int? nullableYear = null;
        Console.WriteLine(nullableYear.HasValue);
        nullableYear = 2023;
        Console.WriteLine(nullableYear.Value);

        // Q12. Declare a string? reviewer = null;. Print whether it is null.
        string? reviewer = null;
        Console.WriteLine(reviewer is null);

        // Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
        Book? optionalBook = null;
        string? title = optionalBook?.Title;
        Console.WriteLine(title);

        // Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to assign title the value "Untitled" only if it's still null.
        Console.WriteLine(title ?? "Untitled");
        title ??= "Untitled";
        Console.WriteLine(title);

        // Q15. Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string confirmedName using the ! operator.
        string? name = "Ahmed";
        string confirmedName = name!;
        Console.WriteLine(confirmedName);
    }
}
