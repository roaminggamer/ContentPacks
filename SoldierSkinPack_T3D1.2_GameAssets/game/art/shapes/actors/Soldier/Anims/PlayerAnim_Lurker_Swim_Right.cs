singleton TSShapeConstructor(PlayerAnim_Lurker_Swim_RightDAE)
{
   baseShape = "./PlayerAnim_Lurker_Swim_Right.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1760", "1820");
}