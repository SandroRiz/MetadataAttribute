# MetadataAttribute

Project to demo an issue with JsonIgnore and MetaDataAttribute

The JsonIgnore attribute is not applied to the ICollection<Books> causing an error of
"A possible object cycle was detected. This can either be due to a cycle or if the object depth is larger than the maximum allowed depth of 64."