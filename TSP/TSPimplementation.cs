public class TSPimplementation
{
    public int CitiesNumber;
    public double FinalResult = int.MaxValue;
    public int[] FinalPath;

    public double FinalResultWrapper => FinalResult;

    public int[] FinalPathWrapper => FinalPath;

    // visited[] keeps track of the already visited nodes
    // in a particular path
    bool[] visited;

    // Function to copy temporary solution to
    // the final solution
    void copyToFinal(int[] currentPath)
    {
        for (int i = 0; i < CitiesNumber; i++)
            FinalPath[i] = currentPath[i];
        FinalPath[CitiesNumber] = currentPath[0];
    }

    // Function to find the minimum edge cost
    // having an end at the vertex i
    double firstMin(double[,] matrix, int i)
    {
        double min = int.MaxValue;
        for (int k = 0; k < CitiesNumber; k++)
            if (matrix[i, k] < min && i != k)
                min = matrix[i, k];
        return min;
    }

    // function to find the second minimum edge cost
    // having an end at the vertex i
    double secondMin(double[,] matrix, int i)
    {
        double first = int.MaxValue, second = int.MaxValue;
        for (int j = 0; j < CitiesNumber; j++)
        {
            if (i == j)
                continue;

            if (matrix[i, j] <= first)
            {
                second = first;
                first = matrix[i, j];
            }
            else if (matrix[i, j] <= second &&
                    matrix[i, j] != first)
                second = matrix[i, j];
        }
        return second;
    }

    // function that takes as arguments:
    // curr_bound -> lower bound of the root node
    // curr_weight-> stores the weight of the path so far
    // level-> current level while moving in the search
    //		 space tree
    // curr_path[] -> where the solution is being stored which
    //			 would later be copied to final_path[]
    void TSPRec(double[,] matrix, double currentBound, double currentWeight, int level, int[] currentPath)
    {
        // base case is when we have reached level N which
        // means we have covered all the nodes once
        if (level == CitiesNumber)
        {
            // check if there is an edge from last vertex in
            // path back to the first vertex
            if (matrix[currentPath[level - 1], currentPath[0]] != 0)
            {
                // curr_res has the total weight of the
                // solution we got
                double currentResult = currentWeight +
                        matrix[currentPath[level - 1], currentPath[0]];

                // Update final result and final path if
                // current result is better.
                if (currentResult < FinalResult)
                {
                    copyToFinal(currentPath);
                    FinalResult = currentResult;
                }
            }
            return;
        }

        // for any other level iterate for all vertices to
        // build the search space tree recursively
        for (int i = 0; i < CitiesNumber; i++)
        {
            // Consider next vertex if it is not same (diagonal
            // entry in adjacency matrix and not visited
            // already)
            if (matrix[currentPath[level - 1], i] != 0 &&
                    visited[i] == false)
            {
                double temp = currentBound;
                currentWeight += matrix[currentPath[level - 1], i];

                // different computation of curr_bound for
                // level 2 from the other levels
                if (level == 1)
                    currentBound -= ((firstMin(matrix, currentPath[level - 1]) +
                                    firstMin(matrix, i)) / 2);
                else
                    currentBound -= ((secondMin(matrix, currentPath[level - 1]) +
                                    firstMin(matrix, i)) / 2);

                // curr_bound + curr_weight is the actual lower bound
                // for the node that we have arrived on
                // If current lower bound < final_res, we need to explore
                // the node further
                if (currentBound + currentWeight < FinalResult)
                {
                    currentPath[level] = i;
                    visited[i] = true;

                    // call TSPRec for the next level
                    TSPRec(matrix, currentBound, currentWeight, level + 1, currentPath);
                }

                // Else we have to prune the node by resetting
                // all changes to curr_weight and curr_bound
                currentWeight -= matrix[currentPath[level - 1], i];
                currentBound = temp;

                // Also reset the visited array
                // Arrays.fill(visited, false);
                visited = new bool[CitiesNumber];
                for (int j = 0; j <= level - 1; j++)
                    visited[currentPath[j]] = true;
            }
        }
    }

    // This function sets up final_path[]
    public void TSP(double[,] matrix)
    {
        CitiesNumber = matrix.GetLength(0);
        visited = new bool[CitiesNumber];

        int[] currentPath = new int[CitiesNumber + 1];
        FinalPath = new int[CitiesNumber + 1];

        // Calculate initial lower bound for the root node
        // using the formula 1/2 * (sum of first min +
        // second min) for all edges.
        // Also initialize the curr_path and visited array
        double currentBound = 0;
        for (int i = 0; i < currentPath.Length; i++)
            currentPath[i] = -1;
        visited = new bool[CitiesNumber];

        // Compute initial bound
        for (int i = 0; i < CitiesNumber; i++)
            currentBound += (firstMin(matrix, i) +
                        secondMin(matrix, i));

        // Rounding off the lower bound to an integer
        currentBound = (currentBound == 1) ? currentBound / 2 + 1 :
                                    currentBound / 2;

        // We start at vertex 1 so the first vertex
        // in curr_path[] is 0
        visited[0] = true;
        currentPath[0] = 0;

        // Call to TSPRec for curr_weight equal to
        // 0 and level 1
        TSPRec(matrix, currentBound, 0, 1, currentPath);
    }
}