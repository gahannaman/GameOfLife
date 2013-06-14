using System;
using TechTalk.SpecFlow;

namespace GameOfLife
{
    [Binding]
    public class GameOfLifeSteps
    {
	    private Grid _grid;
	    private int row;
	    private int column;

        [Given(@"I have a cell")]
        public void GivenIHaveACell()
        {
            _grid = new Grid();
	        _grid.AnimateCell(2, 2);
        }
        
        [Given(@"The cell is dead")]
        public void GivenTheCellIsDead()
        {
	        _cell.Kill();
        }
        
        [Given(@"the cell has a live neighbor to the right")]
        public void GivenTheCellHasALiveNeighborToTheRight()
        {
            _cell.RightNeighbor.IsAlive = true;
        }
        
        [Given(@"the cell has a live neighbor to the left")]
        public void GivenTheCellHasALiveNeighborToTheLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the cell has a live neighbor to the lowerLeft")]
        public void GivenTheCellHasALiveNeighborToTheLowerLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I update the cell")]
        public void WhenIUpdateTheCell()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the NewCell should be alive")]
        public void ThenTheNewCellShouldBeAlive()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
