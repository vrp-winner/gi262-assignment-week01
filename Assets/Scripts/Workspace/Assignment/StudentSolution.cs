using AssignmentSystem.Services;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Examples

        public void As01_SyntaxIf(bool isSixoClock)
        { 
            if (isSixoClock)
            {
                Debug.Log("You can get in");
            }

            Debug.Log("Crack Crack!!!!");
        }

        public void As02_StringComparisonExample(string password)
        {
            if (password == "Moon")
            {
                Debug.Log("password is correct");
            }
            else
            {
                Debug.Log("wrong password");
            }
        }

        public void As03_NumberComparisonExample(int number)
        {
            if (number > 10)
            {
                Debug.Log("My Number > 10");
            }
            if (number < 10)
            {
                Debug.Log("My Number < 10");
            }
            if (number == 10)
            {
                Debug.Log("My Number == 10");
            }
            if (number >= 10)
            {
                Debug.Log("My Number >= 10");
            }
            if (number <= 10)
            {
                Debug.Log("My Number <= 10");
            }
            if (number != 10)
            {
                Debug.Log("My Number != 10");
            }
        }

        public void As04_AndOrOperatorExample(int number)
        {
            if (number > 8 && number < 12)
            {
                Debug.Log("My Number 8 > < 12");
            }

            if (number > 8 || number < 12)
            {
                Debug.Log("My Number or 8 || 12");
            }
        }

        public void As05_GuessingNumberExample(int guessingNumber, int randomNumber)
        {
            Debug.Log($"Guessing number {randomNumber}");
            if (guessingNumber == randomNumber)
            {
                Debug.Log("Congratulations! You guessed the correct number.");
            }
            else
            {
                Debug.Log("I guess we can just agree to disagree.");
            }
        }

        public void As06_GuessingNumberMoreOrLessExample(int guessingNumber, int randomNumber)
        {
            Debug.Log($"Guessing number {randomNumber}");
            if (guessingNumber < randomNumber)
            {
                Debug.Log("Too low! Try again.");
            }
            else if (guessingNumber > randomNumber)
            {
                Debug.Log("Too high! Try again.");
            }
            else
            {
                Debug.Log("Congratulations! We are same mind.");
            }
        }

        public void As07_VerifyIdentityExample(string username, string password, int age, bool isPaid)
        {
            if (username == "user" && password == "user123")
            {
                Debug.Log("You have user access.");
                if (isPaid == true)
                {
                    Debug.Log("welcome vip member.");
                    if (age > 18)
                    {
                        Debug.Log("You have access to exclusive content.");
                    }
                }
                else
                {
                    Debug.Log("welcome free member.");
                }
            }
            else
            {
                Debug.Log("You have guest access.");
            }
        }

        #endregion

        #region Level 1: Simple

        public void Lv01_CheckNumberSign(int number)
        {
            if (number > 0)
            {
                Debug.Log("Positive");
            }
            else if (number < 0)
            {
                Debug.Log("Negative");
            }
            else
            {
                Debug.Log("Zero");
            }
        }

        public void Lv02_GetDayName(int day)
        {
            switch (day)
            {
                case 1: Debug.Log("Monday"); break;
                case 2: Debug.Log("Tuesday"); break;
                case 3: Debug.Log("Wednesday"); break;
                case 4: Debug.Log("Thursday"); break;
                case 5: Debug.Log("Friday"); break;
                case 6: Debug.Log("Saturday"); break;
                case 7: Debug.Log("Sunday"); break;
                default: Debug.Log("Invalid day"); break;
            }
        }

        public void Lv03_ValidatePassword(string inputPassword, string correctPassword)
        {
            if (inputPassword == correctPassword)
            {
                Debug.Log("True");
            }
            else
            {
                Debug.Log("False");
            }
        }

        public void Lv04_GetGrade(int score)
        {
            if (score >= 80)
            {
                Debug.Log("A");
            }
            else if (score >= 70)
            {
                Debug.Log("B");
            }
            else if (score >= 60)
            {
                Debug.Log("C");
            }
            else if (score >= 50)
            {
                Debug.Log("D");
            }
            else
            {
                Debug.Log("F");
            }
        }

        public void Lv05_IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Debug.Log("True");
            }
            else
            {
                Debug.Log("False");
            }
        }

        public void Lv06_Calculate(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+':
                    Debug.Log("Result: " + (num1 + num2));
                    break;
                case '-':
                    Debug.Log("Result: " + (num1 - num2));
                    break;
                case '*':
                    Debug.Log("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Debug.Log("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Debug.Log("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Debug.Log("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }

        public void Lv07_GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
            {
                Debug.Log("It's Winter.");
            }
            else if (month >= 3 && month <= 5)
            {
                Debug.Log("It's Spring.");
            }
            else if (month >= 6 && month <= 8)
            {
                Debug.Log("It's Summer.");
            }
            else if (month >= 9 && month <= 11)
            {
                Debug.Log("It's Fall.");
            }
            else
            {
                Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
            }
        }

        #endregion

        #region Level 2: Moderate

        public void Ex01_PurchasingSystemExample(int quantity, int price, int payment)
        {
            throw new System.NotImplementedException();
        }

        public void Ex02_RockPaperScissorsExample(int userChoice, int computerChoice)
        {
            throw new System.NotImplementedException();
        }

        public void Ex03_CalculateWeaponDamage(string weaponType, int baseDamage)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            throw new System.NotImplementedException();
        }

        public void Ex04_DeterminePlayerRank(int score, int completionTime)
        {
            // TODO: Add your implementation here
            // Example: AssignmentDebugConsole.Log("result as string");
            throw new System.NotImplementedException();
        }

        #endregion

    }
}
