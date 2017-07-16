#include "pch.h"
#include "GreedyBestFirstFinder.h"
#include "Heuristics.h"

namespace Library
{
	GreedyBestFirstFinder::GreedyBestFirstFinder(HeuristicFn_t heuristic)
		: IPathFinder(heuristic, nullptr)
	{
	}


	std::deque<NodePtr> GreedyBestFirstFinder::FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet)
	{
		UNREFERENCED_PARAMETER(closedSet);

		std::deque<NodePtr> path;
		std::priority_queue<NodePtr, std::vector<NodePtr>, Heuristics::GreaterThan> frontier;

		frontier.push(start);
		closedSet.insert(start);

		bool foundPath = false;

		while (frontier.size() > 0)
		{
			auto node = frontier.top();
			frontier.pop();

			for (auto neighbor : node->Neighbors())
			{
				auto neighborShared = neighbor.lock();
				if (closedSet.find(neighborShared) == closedSet.end())
				{
					neighborShared->SetParent(node);
					neighborShared->SetHeuristic(mHeuristicFunction(neighborShared, end));
					frontier.push(neighborShared);
					closedSet.insert(neighborShared);
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
