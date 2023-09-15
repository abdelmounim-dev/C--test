using System.Runtime.InteropServices.Marshalling;

string filePath = @"C:\Users\abdel\learning c#\TestProject\input.txt";

string readText = File.ReadAllText(filePath);

string[] plays = readText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

char[] player1 = new char[plays.Length];
char[] player2 = new char[plays.Length];



int playerScore = 0;
Console.WriteLine(plays.Length);

for (int i = 0; i < plays.Length; i++)
{
    player1[i] = plays[i][0];
    player2[i] = plays[i][2];
    
    if (player2[i] == 'X') {
        switch (player1[i])
        {
            case 'A':
                playerScore += 3;
                break;
            case 'B':
                playerScore += 1;
                break;
            case 'C' :
                playerScore += 2;
                break;

        }
    }
    if (player2[i] == 'Y') {
        playerScore += 3;
        switch (player1[i])
        {
            case 'A':
                playerScore += 1;
                break;
            case 'B':
                playerScore += 2;
                break;
            case 'C' :
                playerScore += 3;
                break;
                
        }
    }
    if (player2[i] == 'Z') {
        playerScore += 6;
        switch (player1[i])
        {
            case 'A':
                playerScore += 2;
                break;
            case 'B':
                playerScore += 3;
                break;
            case 'C' :
                playerScore += 1;
                break;
                
        }
    }
    
}

Console.WriteLine("player score is: " + playerScore);