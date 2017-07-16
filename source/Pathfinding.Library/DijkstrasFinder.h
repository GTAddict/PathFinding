#pragma once
#include "IPathFinder.h"

namespace Library
{
	class DijkstrasFinder : public IPathFinder
	{
	public:

		DijkstrasFinder(CostFn_t costFunction);
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) override;
	};
}
