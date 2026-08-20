using DiceRollGame.Game;

var dice = new Dice(6);
var guessGame = new GuessingGame(dice);
GameResult gameResult = guessGame.Play();
GuessingGame.PrintResult(gameResult);
