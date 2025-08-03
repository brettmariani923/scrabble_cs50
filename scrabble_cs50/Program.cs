#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>

int main(void)
{
    string playerOne = get_string("Player1: ");
    string playerTwo = get_string("Player2: ");

    int length = strlen(playerOne);
    int lengthTwo = strlen(playerTwo);
    int valueOne = 0;
    int valueTwo = 0;

    int letterPoints[] = {1, 3, 3, 2, 1, 4, 2, 4, 1, 8,
    5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10};

    for (int i = 0; i < length; i++)
    {
        valueOne += letterPoints[toupper(playerOne[i]) - 'A'];
    }

    for (int i = 0; i < lengthTwo; i++)
    {
        valueTwo += letterPoints[toupper(playerTwo[i]) - 'A'];
    }

    if (valueOne > valueTwo)
    {
        printf("Player 1 wins!\n");
    }

    else if (valueTwo > valueOne)
    {
        printf("Player 2 Wins!\n");
    }

    else if (valueOne == valueTwo)
    {
        printf("Tie!\n");
    }
}
