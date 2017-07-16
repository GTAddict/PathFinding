#include "pch.h"

int main(int argc, char* argv[])
{
#if defined(DEBUG) | defined(_DEBUG)
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
#endif

	UNREFERENCED_PARAMETER(argc);
	UNREFERENCED_PARAMETER(argv);

	using namespace Library;

	int32_t width, height;
	Graph g = GridHelper::LoadGridFromFile("Grid.grid", width, height);
	StopWatch stopWatch;

	std::vector<std::shared_ptr<IPathFinder>> pathFinders;
	pathFinders.push_back(std::make_shared<AStarFinder>(Heuristics::ManhattanDistance, Heuristics::ConstantOneDistance));
	
	for (auto finder : pathFinders)
	{
		g.Reset();
		std::set<NodePtr> collection;
		for (auto node : path)
		{
			collection.insert(node);
		}

		std::cout << "=======================================================" << std::endl;
		std::cout << "=======================================================" << std::endl;
		for (int32_t j = 0; j < height; ++j)
		{
			for (int32_t i = 0; i < width; ++i)
			{
				if (collection.find(g.At(i, j)) != collection.end())
				{
					std::cout << "X ";
				}
				else
				{
					std::cout << (g.At(i, j)->Type() == NodeType::Normal ? "- " : "| ");
				}
			}

			std::cout << std::endl;
		}
		std::cout << "=======================================================" << std::endl;
		std::cout << "=======================================================" << std::endl;
	}

	system("pause");

	return 0;
}
