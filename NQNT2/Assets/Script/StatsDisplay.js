#pragma strict

function Start () {

}

function Update () {

}
//var tagObjet : String = "Sol" ; // Vérifiez bien que le gameObject possède le tag
var limiteDetection : float = 250.0 ; // Définir la limite de distance au delà de laquelle le clic n’est plus prit en compte

function  DetecterObjet(){
    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Droite (rayon) qui passe par le centre de la caméra et la positon de la souris
    var hit : RaycastHit ;
    if(Physics.Raycast(ray, hit, limiteDetection)){ 
        //Le rayon est lancé. Sa taille sera égale à  limiteDetection. Les objets en contact avec le rayon "ray" sont stockés dans la variable hit.
        if(hit.transform.CompareTag( "enemy" )){
            //Si le tag correspond, faites ce que vous voulez
            Debug.Log("Tu es sur un ennemi" ) ; // La variable “hit.point” (Vector3) contient  les coordonnés
        }
    }
}