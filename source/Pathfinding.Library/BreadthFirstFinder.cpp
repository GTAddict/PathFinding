#include "pch.h"
#include "BreadthFirstFinder.h"

namespace Library
{
	std::deque<NodePtr> BreadthFirstFinder::FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet)
	{
		UNREFERENCED_PARAMETER(closedSet);

		std::deque<NodePtr> path;
		std::queue<NodePtr> frontier;
		closedSet.clear();

		frontier.push(start);
		closedSet.insert(start);

		bool foundPath = false;

		while (frontier.size() > 0)
		{
			auto node = frontier.front();
			frontier.pop();

			for (auto neighbor : node->Neighbors())
			{
				auto neighborShared = neighbor.lock();
				if (closedSet.find(neighborShared) == closedSet.end() && neighborShared->Type() != NodeType::Wall)
				{
					neighborShared->SetParent(node);
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

	std::string BreadthFirstFinder::GetName() const
	{
		return "Breadth First Search";
	}
}
