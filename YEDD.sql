select * from Pose;


select p.CommonName
from Pose p
where p.PoseId in (

select 
	pr.PrepPosePoseId
from Pose p
join PoseRelationship pr
	on p.PoseId = pr.BasePosePoseId
where p.PoseId = 3);