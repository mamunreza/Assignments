namespace Builder.BuilderContracts
{
    public interface IMultiStoryBuilder : ISingleStoryBuilder
    {
        void BuildMultiStory(int count);
    }
}