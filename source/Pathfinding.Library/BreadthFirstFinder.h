#pragma once
#include "IPathFinder.h"

namespace Library
{
	class BreadthFirstFinder final : public IPathFinder
	{
	public:

		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) override;
	};
}