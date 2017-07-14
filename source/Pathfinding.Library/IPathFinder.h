#pragma once

#include "Node.h"
#include <deque>
#include <set>
#include <memory>

namespace Library
{
	class Graph;

	using NodePtr = std::shared_ptr<Node>;

	class IPathFinder
	{
	public:
		virtual ~IPathFinder() { };
		virtual std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) = 0;
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end);
	};
}