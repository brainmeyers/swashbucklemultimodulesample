using Microsoft.AspNetCore.Mvc.ApplicationModels;

internal class TestExplorerGroup : IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        if (controller.ControllerName == "TimeController")
            controller.ApiExplorer.GroupName = "Time-V1";
        else
            controller.ApiExplorer.GroupName = "Weather-V3";
    }
}