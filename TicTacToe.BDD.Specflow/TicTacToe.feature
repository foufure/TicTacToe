Feature: TicTacToe
	In order to enjoy my time on my computer
	As a player
	I want to be able to play TicTacToe

Background:
	Given I have started a game

@mytag
Scenario: Cross Wins
	Given I have entered a "X" at position "A0"
	And I have entered a "O" at position "A1"
	And I have entered a "X" at position "B1"
	And I have entered a "O" at position "A2"
	When I enter a "X" at position "C2"
	Then the "X" is the winner
