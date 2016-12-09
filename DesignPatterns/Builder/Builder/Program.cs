namespace Builder
{
    using System;

    using Builder.BuilderContracts;
    using Builder.Builders;
    using Builder.DirectorContracts;
    using Builder.Directors;

    class Program
    {
        static void Main(string[] args)
        {
            ISingleStoryBuildingDirector singleStoryBuildingDirector = new SingleStoryBuildingDirector();
            IMultiStoryBuildingDirector multiStoryBuildingDirector = new ThreeStoryBuildingDirector();

            ISingleStoryBuilder singleStoryBuilder = null;
            IMultiStoryBuilder multiStoryBuilder = null;

            singleStoryBuilder = new SingleStoryBrickBuilder();
            singleStoryBuildingDirector.Construct(singleStoryBuilder);
            Console.WriteLine("A new house is built:\n\n{0}", singleStoryBuilder.Building.ToString());
            Console.WriteLine(string.Empty);

            multiStoryBuilder = new MultiStoryEconomyBuilder();
            multiStoryBuildingDirector.Construct(multiStoryBuilder);
            Console.WriteLine("A new house is built:\n\n{0}", multiStoryBuilder.Building.ToString());
            Console.WriteLine(string.Empty);

            singleStoryBuilder = new SingleStoryGlassBuilder();
            singleStoryBuildingDirector.Construct(singleStoryBuilder);
            Console.WriteLine("A new house is built:\n\n{0}", singleStoryBuilder.Building.ToString());

            multiStoryBuilder = new MultiStoryLuxuriousBuilder();
            multiStoryBuildingDirector.Construct(multiStoryBuilder);
            Console.WriteLine("A new house is built:\n\n{0}", multiStoryBuilder.Building.ToString());
            Console.WriteLine(string.Empty);

            Console.ReadKey();
        }
    }
}
