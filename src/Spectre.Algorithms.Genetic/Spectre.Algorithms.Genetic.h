// Spectre.Algorithms.Genetic.h

#pragma once

using namespace System;

public class GeneticAlgorithm
{
public:
	GeneticAlgorithm(IDataset data, IMutation mutation, ICrossover crossover, ISelection selection, IClassifier classifier, long generationSize);
	~GeneticAlgorithm();

private:
	IDataset data;
	IMutation mutation;
	ICrossover crossover;
	ISelection selection;
	IClassifier classifier;
	Generation generationCurrent, generationNew;
	long generationSize;
};
