#pragma once
#include "Node.h"

namespace Library
{
	class Heuristics final
	{
	public:

		struct GreaterThan
		{
			bool operator()(const std::shared_ptr<Node>& lhs, const std::shared_ptr<Node>& rhs) const;
		};

		static float ManhattanDistance(std::shared_ptr<Node> current, std::shared_ptr<Node> end);
		static float ConstantOneDistance(std::shared_ptr<Node> node, std::shared_ptr<Node> neighbor);
	};
}