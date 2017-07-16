#pragma once
#include "AStarFinder.h"

namespace Library
{
	class DijkstrasFinder final : public AStarFinder
	{
	public:

		DijkstrasFinder(CostFn_t costFunction);
		~DijkstrasFinder() override = default;

		std::string GetName() const override;
	};
}
