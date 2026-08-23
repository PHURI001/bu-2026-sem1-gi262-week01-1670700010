
using UnityEngine;

//By Mr.Phuriwat Chatwichaiphat 1670700010 Sec.329B
//No ai prompt, make my me, I love you so much my professor.
public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");

        /* I understand that it means: finding out whether it's a positive or negative value.*/

        if (as01Number > 0)
            Debug.Log("Positive");
        else if (as01Number < 0)
            Debug.Log("Negative");
        else //its 0
            Debug.Log("neutral");

        //throw new System.NotImplementedException();
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");

        /* I understand that: Print out the days of the week, from 1 to 7.*/
        switch (as02Day)
        {
            case 1:
                Debug.Log("Sunday");
                break;
            case 2:
                Debug.Log("Monday");
                break;
            case 3:
                Debug.Log("Tuesday");
                break;
            case 4:
                Debug.Log("Wednesday");
                break;
            case 5:
                Debug.Log("Thursday");
                break;
            case 6:
                Debug.Log("Friday");
                break;
            case 7:
                Debug.Log("Saturday");
                break;
            default:
                Debug.Log("Try again");
                break;
        }

        //throw new System.NotImplementedException();
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");

        /* I understand that: I need to enter the correct or incorrect code.*/
        if (as03InputPassword == as03CorrectPassword)
            Debug.Log("true");
        else
            Debug.Log("false");

        //throw new System.NotImplementedException();
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");

        /* I understand that: The grade is assigned based on a score of 100.*/
        if (as04Score >= 80)
            Debug.Log("A");
        else if (as04Score >= 75)
            Debug.Log("B+");
        else if (as04Score >= 70)
            Debug.Log("B");
        else if (as04Score >= 65)
            Debug.Log("C+");
        else if (as04Score >= 60)
            Debug.Log("C");
        else if (as04Score >= 55)
            Debug.Log("D+");
        else if (as04Score >= 50)
            Debug.Log("D");
        else //its <49
            Debug.Log("F");

        //throw new System.NotImplementedException();
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");

        /* I understanding is: Find the year that has one extra day each year, provided the result is divisible by 4 and 400 but not 100.*/
        if (as05Year % 400 == 0 || (as05Year % 4 == 0 && as05Year % 100 != 0))
            Debug.Log("True");
        else
            Debug.Log("false");

        //throw new System.NotImplementedException();
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");

        /* I understand that: A calculator should be able to perform addition (+), subtraction (-), multiplication (*), and division (/).*/
        switch (as06Op)
        {
            case '+':
                Debug.Log($"Result: {as06Num1 + as06Num2}");
                break;
            case '-':
                Debug.Log($"Result: {as06Num1 - as06Num2}");
                break;
            case '*':
                Debug.Log($"Result: {as06Num1 * as06Num2}");
                break;
            case '/':
                if (as06Num2 != 0)
                    Debug.Log($"Result: {as06Num1 / as06Num2}");
                else
                    Debug.Log("Cannot divide by zero");
                break;
            default:
                Debug.Log("Try again");
                break;
        }

        //throw new System.NotImplementedException();
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");

        /* I understand that: Checking what season it is in each of the 12 months, based on the Thai season.*/
        //Season in Tailand
        switch (as07Month)
        {
            case 1:
            case 2:
            case 11:
            case 12:
                Debug.Log("Cool Season");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("Hot Season");
                break;
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Debug.Log("Rainy Season");
                break;
            default:
                Debug.Log("Try again");
                break;
        }

        //throw new System.NotImplementedException();
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        /* I understanding is: The payment system should calculate the quantity of items by the price, subtract our available funds, and the result should indicate whether the payment was successful or not.*/
        int summary = as08Payment - (as08Quantity * as08Price);

        if (summary >= 0)
        {
            Debug.Log($"Quantity: {as08Quantity} Price: {as08Price} Your Money: {as08Payment}");
            Debug.Log($"Bought! Your money: {summary}");
        }
        else if (summary < 0)
            Debug.Log("Not enough money");

        //throw new System.NotImplementedException();
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        /* I understanding is: Players draw numbers to aim at a target, the bot selects and displays whether they win or lose.*/
        Debug.Log("1:Rock, 2:Paper, 3:scissor");
        //as09ComputerChoice = Random.Range(1, 4);
        //Debug.Log($"Computer: {as09ComputerChoice}");

        if (as09UserChoice == as09ComputerChoice)
            Debug.Log("Draw");
        else if (as09UserChoice == 1)
        {
            switch (as09ComputerChoice)
            {
                case 2:
                    Debug.Log("You lose");
                    break;
                case 3:
                    Debug.Log("You win");
                    break;
                default:
                    break;
            }
        }
        else if (as09UserChoice == 2)
        {
            switch (as09ComputerChoice)
            {
                case 1:
                    Debug.Log("You win");
                    break;
                case 3:
                    Debug.Log("You lose");
                    break;
                default:
                    break;
            }
        }
        else if (as09UserChoice == 3)
        {
            switch (as09ComputerChoice)
            {
                case 1:
                    Debug.Log("You lose");
                    break;
                case 2:
                    Debug.Log("You win");
                    break;
                default:
                    break;
            }
        }

        //throw new System.NotImplementedException();
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");

        /* I understand that the problem asks me to calculate the damages ourselves using the Bidder method and show the results.*/
        int newDamage = as10BaseDamage * 2; //basic player critical stats
        Debug.Log($"You use: {as10WeaponType}, Base Damage With Critical(x2): {newDamage}.");

        //throw new System.NotImplementedException();
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");

        /* My understanding is: Create a game and display your rank. I'm using a Roblox clicker game where the number of clicks depends on your power, which is roughly calculated by multiplying the time taken to reach the player's actual power, and then displays your rank.*/
        //Rep Roblox tycoon game (clicker game)
        int result = as11Score * as11CompletionTime;
        if (result >= 99999)
            Debug.Log("God rank");
        else if (result >= 4999)
            Debug.Log("Hacker rank");
        else if (result >= 2999)
            Debug.Log("Pro rank");
        else if (result >= 999)
            Debug.Log("Intermediate  rank");
        else
            Debug.Log("Noob  rank");

        //throw new System.NotImplementedException();
    }
}