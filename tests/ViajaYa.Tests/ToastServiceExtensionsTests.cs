using BlazorBootstrap;
using ViajaYa.Extensors;

namespace ViajaYa.Tests;

public class ToastServiceExtensionsTests
{
    [Fact]
    public void ShowSuccess_DebeCrearToastDeExito()
    {
        var toastService = new ToastService();

        var resultado = toastService.ShowSuccess("Guardado correctamente");

        Assert.Equal(ToastType.Success, resultado.Type);
        Assert.Equal("Success", resultado.Title);
        Assert.Equal("Guardado correctamente", resultado.Message);
    }

    [Fact]
    public void ShowWarning_DebeCrearToastDeAdvertencia()
    {
        var toastService = new ToastService();

        var resultado = toastService.ShowWarning("Revisa los datos");

        Assert.Equal(ToastType.Warning, resultado.Type);
        Assert.Equal("Warning", resultado.Title);
        Assert.Equal("Revisa los datos", resultado.Message);
    }

    [Fact]
    public void ShowError_DebeCrearToastDeError()
    {
        var toastService = new ToastService();

        var resultado = toastService.ShowError("Ocurrio un error");

        Assert.Equal(ToastType.Danger, resultado.Type);
        Assert.Equal("Error", resultado.Title);
        Assert.Equal("Ocurrio un error", resultado.Message);
    }
}
