using PampangaCommunityWebSite.Client.Entities;

namespace PampangaCommunityWebSite.Client.Components;
public partial class SlidesComponent
{
    List<SlideItem> Slides = [];

    int TotalSlides;
    int ActualSlide = 0;
    bool IsStopAnimation = false;

    protected override void OnInitialized()
    {
        for (int i = 0; i < 5; i++)
        {
            Slides.Add(new SlideItem
            {
                Title = $"HELP A CHILD WITHOUT FAMILY {i + 1}",
                SubTitle = $"AENEAN MAXIMUS IN SEM. {i + 1}"
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
        if (!IsStopAnimation)
        {
            Slides.ForEach(s => s.IsVisible = false);
            ActualSlide++;
            if (ActualSlide >= TotalSlides)
                ActualSlide = 0;
            Slides[ActualSlide].IsVisible = true;
            await InvokeAsync(StateHasChanged);
            await Task.Delay(1500);
            await StartSpool();
        }
    }

    void StopAnimation(int index)
    {
        IsStopAnimation = true;
        Slides.ForEach(s => s.IsVisible = false);
        Slides[index].IsVisible = true;
        ActualSlide = index;
        Task.Run(async () => 
        {
            await Task.Delay(5000);
            IsStopAnimation = false;
            await StartSpool();
        });
    }

}