using Gherkin.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace SimpleMvvmTest;

[FeatureFile("./test.feature")]
public class FeatureTest : Feature
{
    private MainViewModel? MainViewModel { get; set; }

    [Given(@"I launch the application")]
    public void LaunchApp()
    {
        MainViewModel = new MainViewModel();
    }

    [When(@"I press button (\d+) times")]
    public void PressButton(int count)
    {
        for(int i = 0; i < count; i++)
        {
            MainViewModel?.ButtonClicked();
        }
    }

    [Then(@"label will be:")]
    public void LabelWillBe(DocString expected)
    {
        Assert.Equal(expected.Content, MainViewModel?.Label);
    }
}
