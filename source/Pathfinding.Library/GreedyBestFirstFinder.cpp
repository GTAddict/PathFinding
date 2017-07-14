#include "pch.h"
#include "GreedyBestFirstFinder.h"

namespace Library
{
	GreedyBestFirstFinder::GreedyBestFirstFinder(HeuristicType heuristic)
		: IPathFinder(heuristic)
	{
	}


	std::deque<NodePtr> GreedyBestFirstFinder::FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet)
	{
		UNREFERENCED_PARAMETER(closedSet);

		std::deque<NodePtr> path;
		std::priority_queue<NodePtr> frontier;
		std::set<NodePtr> visited;

		frontier.push(start);
		visited.insert(start);

		bool foundPath = false;

		while (frontier.size() > 0)
		{
			auto node = frontier.top();
			frontier.pop();

			for (auto neighbor : node->Neighbors())
			{
				auto neighborShared = neighbor.lock();
				if (visited.find(neighborShared) == visited.end())
				{
					neighborShared->SetParent(node);
					neighborShared->SetHeuristic(mHeuristicFunction(neighborShared, end));
					frontier.push(neighborShared);
					visited.insert(neighborShared);
					if (neighborShared == end)
					{
						foundPath = true;
						break;
					}
				}
			}

			if (foundPath)
			{
				break;
			}
		}

		if (foundPath)
		{
			NodePtr current = end;

			path.push_front(end);

			while (current != start)
			{
				NodePtr parent = current->Parent().lock();
				path.push_front(parent);
				current = parent;
			}

		}

		return path;
	}
}
