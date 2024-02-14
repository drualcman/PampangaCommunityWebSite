using PampangaCommunityWebSite.Client.Models;

namespace PampangaCommunityWebSite.Client.Components;
public partial class SlidesComponent
{
    List<SlideItem> Slides = [];

    int TotalSlides;
    int ActualSlide = 0;

    protected override void OnInitialized()
    {
        for (int i = 0; i < 5; i++)
        {
            Slides.Add(new SlideItem
            {
                Title = $"Slide {i + 1}",
                SubTitle = $"Subtitle {i + 1}"
            });
        }
        Slides[0].IsVisible = true;
        TotalSlides = Slides.Count;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await StartSpool();
        }
    }


    async Task StartSpool()
    {
        await Console.Out.WriteLineAsync($"StartSpool {ActualSlide}");
        Slides.ForEach(s=> s.IsVisible = false);
        ActualSlide++;
        if (ActualSlide >= TotalSlides)
            ActualSlide = 0;
        Slides[ActualSlide].IsVisible = true;
        await InvokeAsync(StateHasChanged);
        await Task.Delay(1500);        
        await StartSpool();
    }


}