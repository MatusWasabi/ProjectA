using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class RecipeLearnt : MonoBehaviour
{
    [FormerlySerializedAs("recipeTextMest")] [SerializeField] private TextMeshProUGUI recipeTextMesh;

    public void ShowNewRecipes(Component sender, object combinationData)
    {
        List<CombinationData> recipes = (List<CombinationData>)combinationData;
        CombinationData recipe = recipes[0];
        string substance = recipe.ToString().Split(new char[] {' '})[0];
        string component = recipe.data[0].component;
        string product = recipe.data[0].product.name;

        recipeTextMesh.text = $"New Recipe Learn \n {substance} + {component} \n = {product}";
    } 
}
