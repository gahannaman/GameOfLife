Feature: GameOfLife
	In order to learn spec flow
	As a programmer
	I want to implement the game of life

@welcomeToGherkin
Scenario: When cell has three live neighbors
	Given I have a cell
	And The cell is dead
	And the cell has a live neighbor to the right
	And the cell has a live neighbor to the left
	And the cell has a live neighbor to the lowerLeft
	When I update the cell
	Then the NewCell should be alive
