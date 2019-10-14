using SFWSPAutomationFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSpecificationBeta.StepDefinitions
{
    [Binding]
    public sealed class MessageBoardSteps : Steps
    {
        [Given(@"all games are checked")]
        public void GivenAllGamesAreChecked()
        {
            Given("the Modern Warfare Three checkbox is checked");
            Given("the Black Ops checkbox is checked");
            Given("the Mario Paint checkbox is checked");
        }

        [Given("the Modern Warfare Three checkbox is checked")]
        public void GivenTheModernWarfareThreeCheckboxIsChecked()
        {
            HomePage.CheckModernWarfare3();
        }

        [Given("the Black Ops checkbox is checked")]
        public void GivenTheBlackOpsCheckboxIsChecked()
        {
            HomePage.CheckBlackOps();
        }

        [Given("the Mario Paint checkbox is checked")]
        public void GivenTheMarioPaintCheckboxIsChecked()
        {
            HomePage.CheckMarioPaint();
        }

        [When("the Submit Games button is clicked")]
        public void WhenTheSubmitGamesButtonIsClicked()
        {
            HomePage.ClickSubmitGamesButton();
        }

        [Then("the message board displays (.*)")]
        public void ThenTheMessageBoardDisplays(string message)
        {
            HomePage.ClickResetButton();
        }

        [Then(@"all games appear in the messageboard")]
        public void ThenAllGamesAppearInTheMessageboard()
        {
            var games = new List<string>()
            {
                @"Modern Warfare 3",
                @"Black Ops",
                @"Mario Paint"
            };
            games.ForEach(game => Then(string.Format(@"the message board displays '{0}'", game)));
        }

    }
}
