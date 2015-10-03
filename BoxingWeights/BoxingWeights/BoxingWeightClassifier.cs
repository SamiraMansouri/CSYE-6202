namespace BoxingWeights
{
    public class BoxingWeightClassifier
	{
		public string ClassifyBoxingWeight(int weightInPounds)
		{
			string result = weightInPounds.ToString();

            if (weightInPounds <= 105)
            {
                result = BoxingWeights.Constants.Strawweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 108)
            {
                result = BoxingWeights.Constants.JuniorFlyweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 112)
            {
                result = BoxingWeights.Constants.Flyweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 115)
            {
                result = BoxingWeights.Constants.JuniorBantamweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 118)
            {
                result = BoxingWeights.Constants.Bantamweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 122)
            {
                result = BoxingWeights.Constants.JuniorFeatherweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 126)
            {
                result = BoxingWeights.Constants.Featherweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 130)
            {
                result = BoxingWeights.Constants.JuniorLightweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 135)
            {
                result = BoxingWeights.Constants.Lightweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 140)
            {
                result = BoxingWeights.Constants.JuniorWelterweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 147)
            {
                result = BoxingWeights.Constants.Welterweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 154)
            {
                result = BoxingWeights.Constants.JuniorMiddleweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 160)
            {
                result = BoxingWeights.Constants.Middleweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 168)
            {
                result = BoxingWeights.Constants.SuperMiddleweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 175)
            {
                result = BoxingWeights.Constants.LightHeavyweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else if (weightInPounds <= 200)
            {
                result = BoxingWeights.Constants.Cruiserweight + " and " + BoxingWeights.Constants.Heavyweight;
            }
            else 
            {
                result = BoxingWeights.Constants.Heavyweight;
            }
            
            return result;
		}
	}
}
